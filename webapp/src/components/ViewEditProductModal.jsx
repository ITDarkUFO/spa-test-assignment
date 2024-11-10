import { useEffect, useState } from 'react';
import axios from '../api/axios';

import { Button, Modal, Form } from 'antd';
import { CloseOutlined, EditOutlined, SaveOutlined } from '@ant-design/icons';

import { useDataFetch } from '../context/DataFetchContext';
import { useModal } from '../context/ModalContext';

import ProductViewForm from './ProductViewForm';
import ProductForm from './ProductForm';

const ViewEditProductModal = () => {
    const { dispatch } = useDataFetch();
    const {
        isViewEditModalVisible: isModalVisible,
        setIsViewEditModalVisible: setIsModalVisible,
        viewEditModalProductId: productId,
        setViewEditModalProductId: setProductId
    } = useModal();

    const [isLoading, setIsLoading] = useState(false);
    const [isEditMode, setIsEditMode] = useState(false);
    const [isFormDisabled, setIsFormDisabled] = useState(false);

    const [productData, setProductData] = useState(null);

    const [viewForm] = Form.useForm();
    const [editForm] = Form.useForm();

    useEffect(() => {
        if (productId != null) {
            setIsLoading(true);
            fetchDataAsync();
        }
    }, [productId]);

    const fetchDataAsync = async () => {
        try {
            console.log(`Запрос информации о товаре ${productId}`);
            const response = await axios.get(`/api/products/${productId}`);
            console.debug(response);

            setProductData(response.data);
            viewForm.setFieldsValue(response.data);
        }
        catch (error) {
            console.error(error);
        }
        finally {
            setIsLoading(false);
        }
    }

    const submitFormAsync = async () => {
        try {
            var validateResults = await editForm.validateFields();
            setIsFormDisabled(true);

            console.log(`Запрос на обновление товара ${productData.Id}`);
            const response = await axios.put(`/api/products/${productData.Id}`, validateResults);
            console.log(response);

            setIsModalVisible(false);
            setProductId(null);
            setIsEditMode(false);

            dispatch({ type: 'TOGGLE_FETCH' });

            editForm.resetFields();
        }
        catch (error) {
            console.log(error);

            const errors = Object.keys(error.response.data.errors).map((field => ({
                name: field,
                errors: [error.response.data.errors[field]],
            })));
            editForm.setFields(errors);
        }
        finally {
            setIsFormDisabled(false);
        }
    }

    const handleClose = () => {
        setIsModalVisible(false);
        setIsEditMode(false);
    };

    const changeEditMode = () => {
        setIsEditMode(!isEditMode);
        editForm.setFieldsValue(productData);
    };

    const ProductData = () => {
        if (!isLoading) {
            if (!isEditMode) {
                return (<ProductViewForm form={viewForm} />);
            }
            else {
                return (<ProductForm form={editForm} isFormDisabled={isFormDisabled} />);
            }
        }
    };

    const ModalTitle = isEditMode ? "Редактирование товара" : "Просмотр товара";

    const FooterButtons = () => {
        if (isEditMode) {
            return (
                <>
                    <Button icon={<CloseOutlined />} onClick={changeEditMode}>Отменить редактирование</Button>
                    <Button icon={<SaveOutlined />} type="primary" key="back" onClick={submitFormAsync}>Сохранить</Button>
                </>
            );
        }
        else {
            return (
                <>
                    <Button icon={<EditOutlined />} onClick={changeEditMode}>Редактировать товар</Button>
                    <Button icon={<CloseOutlined />} key="back" onClick={handleClose}>Закрыть</Button>
                </>
            );
        }
    };

    return (
        <Modal title={ModalTitle}
            loading={isLoading}
            open={isModalVisible}
            onCancel={handleClose}
            footer={FooterButtons}>
            <ProductData />
        </Modal>
    );
};

export default ViewEditProductModal;